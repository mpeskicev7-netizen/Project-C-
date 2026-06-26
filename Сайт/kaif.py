from flask import Flask, render_template, request, redirect, url_for, flash, abort
from flask_login import UserMixin, LoginManager, login_user, logout_user, login_required, current_user
from functools import wraps
from werkzeug.security import generate_password_hash, check_password_hash
from flask_sqlalchemy import SQLAlchemy

kaif = Flask(__name__)
kaif.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///blog.db'
kaif.secret_key = 'заменить на свой ключ'
db = SQLAlchemy(kaif)

login_manager = LoginManager()
login_manager.init_app(kaif)
login_manager.login_view = 'login'


@login_manager.user_loader
def load_user(user_id):
    return User.query.get(int(user_id))


class Bikes(db.Model):
    id = db.Column(db.Integer, primary_key = True)
    name = db.Column(db.String(200), nullable = False)
    description = db.Column(db.String(400), nullable = False)
    price_week = db.Column(db.Integer, nullable = False)
    image = db.Column(db.String(200), nullable = True)
    quantity = db.Column(db.Integer, nullable = False, default = 1)

    def __repr__(self):
        return '<Bikes %r>' % self.id


class User(db.Model, UserMixin):
    id = db.Column(db.Integer, primary_key = True)
    email = db.Column(db.String(150), unique = True, nullable = False)
    password_hash = db.Column(db.String(200), nullable = False)
    name = db.Column(db.String(100), nullable = False)
    is_admin = db.Column(db.Boolean, default = False, nullable = False )

    def set_password(self, password):
        self.password_hash = generate_password_hash(password)
    
    def check_password(self, password):
        return check_password_hash(self.password_hash, password)
    
    def __repr__(self):
        return '<User %r>' % self.name
    
def admin_required(f):
    @wraps(f)
    def decorated_function(*args, **kwargs):
        if not current_user.is_authenticated or not current_user.is_admin:
            abort(403)
        return f(*args, **kwargs)
    return decorated_function


@kaif.route('/')
def index():
    bikes = Bikes.query.all()
    return render_template("index.html", bikes = bikes)


@kaif.route('/register', methods = ['GET', 'POST'])
def register():
    if request.method == 'POST':
        email = request.form['email']
        password = request.form['password']
        name = request.form['name']

        existing_user = User.query.filter_by(email=email).first()
        if existing_user:
            flash('Пользователь с такой почтой уже зарегестрирован')
            return redirect(url_for('register'))
        
        new_user = User(email=email, name=name)
        new_user.set_password(password)

        db.session.add(new_user)
        db.session.commit()

        flash('Регистрация прошла успешно')
        return redirect(url_for('login'))
    
    return render_template('register.html')


@kaif.route('/login', methods = ['GET', 'POST'])
def login():
    if request.method == 'POST':
        email = request.form['email']
        password = request.form['password']

        user = User.query.filter_by(email=email).first()

        if user and user.check_password(password):
            login_user(user)
            return redirect(url_for('index'))
        else:
            flash('Неверная почта или пароль')
            return redirect(url_for('login'))
        
    return render_template('login.html')


@kaif.route('/admin/bikes')
@login_required
@admin_required
def admin_bikes():
	bikes = Bikes.query.all()
	return render_template('admin_bikes.html', bikes=bikes)


@kaif.route('/logout')
@login_required
def logout():
	logout_user()
	return redirect(url_for('index'))

if __name__ == "__main__":
    kaif.run(debug=True, host="0.0.0.0")