from flask import Flask, render_template, url_for, abort, request, redirect, flash
from flask_login import UserMixin, LoginManager, login_user, logout_user, login_required, current_user
from functools import wraps
import os
from werkzeug.security import generate_password_hash, check_password_hash
from flask_sqlalchemy import SQLAlchemy

order = Flask(__name__)
order.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///blog.db'
order.secret_key = 'secret-key'
db = SQLAlchemy(order)

login_manager = LoginManager()
login_manager.init_app(order)
login_manager.login_view = 'login'


@login_manager.user_loader
def load_user(user_id):
    return User.query.get(int(user_id))


class User(db.Model, UserMixin):
    id = db.Column(db.Integer, primary_key = True)
    email = db.Column(db.String(150), unique = True, nullable = False)
    password_hash = db.Column(db.String(200), nullable = False)
    name = db.Column(db.String(100), nullable = False)
    is_admin = db.Column(db.Boolean, default = False, nullable = False)

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


@order.route('/')
def index():
    return render_template("index.html")


@order.route('/register', methods = ['GET', 'POST'])
def register():
    if request.method == 'POST':
        email = request.form['email']
        password = request.form['password']
        name = request.form['name']

        existing_user = User.query.filter_by(email=email).first()

        if existing_user:
            flash('Пользователь с такой почтой уже существует!')
            return redirect(url_for('register'))
        
        new_user = User(email=email, name=name)
        new_user.set_password(password)

        db.session.add(new_user)
        db.session.commit()

        flash('Регистрация прошла успешно')
        return redirect(url_for('login'))
    
    return render_template('register.html')



@order.route('/login', methods = ['GET', 'POST'])
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
    return render_template("login.html")


@order.route('/account')
@login_required
def account():
    user = User.query.all()
    return render_template("account.html", user=user)


@order.route('/logout')
@login_required
def logout():
    logout_user()
    return redirect(url_for('index'))

if __name__ == "__main__":
    order.run(debug=True, host="0.0.0.0")