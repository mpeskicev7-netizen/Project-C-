from kaif import db, kaif, Bikes

with kaif.app_context():
    db.create_all()
    bike1 = Bikes(name="Monster M2", description="Запас хода 60-80 км, мощность 250-500 Вт", price_week=3500, quantity=10)
    db.session.add(bike1)
    db.session.commit()
