from kaif import db, kaif, User

with kaif.app_context():
    db.create_all()
    user = User.query.filter_by(id=1).first()
    user.email = 'popa@gmail.com'
    db.session.commit()