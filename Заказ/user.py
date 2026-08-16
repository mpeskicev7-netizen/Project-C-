from order import db, order, User
from werkzeug.security import generate_password_hash

with order.app_context():
    db.create_all()
    password = generate_password_hash('Macs1349500')
    admin = User(id = 1, email = 'mpeskicev7@gmail.com', password_hash = password, name = 'Admin', is_admin = True)
    db.session.add(admin)
    db.session.commit()