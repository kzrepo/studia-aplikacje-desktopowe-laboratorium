# Programowanie desktopowych aplikacji biznesowych - Laboratorium

**Semestr 5** - mgr Artur Kornatka
[Link do przedmiotu](https://wsb-nlu.clouda.edu.pl/Kursy/ListaKursow?idPrzedmiotEdycja=58592)

### Projekt bazy danych

Zakładamy, że projektujemy bazę danych dla hurtowni materiałów budowlanych.

**Towar**
- IdTowaru
- Kod
- IdKategoriiTowaru
- Nazwa

**PrzyjęcieZewnetrzneTowaru**
- IdPrzyjeciaZewnetrznegoTowaru
- DataCzasPrzyjecia
- IdPracownikaPrzyjmujacego
- IdKontrahenta

**PozycjaPrzyjeciaZewnetrznegoTowaru**
- IdPozycjiPrzyjeciaZewnetrzenego
- IdPrzyjeciaZewnetrznegoTowaru
- IdTowarJednostkiMiaryTowaru
- Ilosc
- CenaNettoZakupu
- IdStawkiVatZakupu
- IdLokalizacji

**Lokalizacja**
- IdLokalizacji
- Nazwa
- Opis

**Kontrahent**
- IdKontrahenta
- Nazwa
- Nip
- Regon
- IdAdresuGlownego
- Telefon1
- Telefon2
- Email

**Adres**
- IdAdresu
- Miejscowosc
- Ulica
- NrDomu
- NrLokalu
- KodPocztowy
- Poczta
- IdGminy
- IdKraju

**Pracownik**
- IdPracownika
- Imie
- Nazwisko
- Login

**TowarJednostkaMiaryTowaru**
- IdTowarJednostkiMiaryTowaru
- IdTowaru
- IdJednostkiMiaryTowaru

**JednostakaMiaryTowaru** (tabela słownikowa)
- IdJednostkiMiaryTowaru
- Nazwa
- Opis
- Parametry

**KategoriaTowaru** (tabela słownikowa)
- IdKategoriiTowaru
- Nazwa
- Opis
- Uwagi

**ZmianaCenyTowar**
- IdZmianyCenyTowaru
- IdTowarJednostkaMiaryTowaru
- DataCzasObowiazywaniaOd
- DataCzasOwowiazywaniaDo
- CenaNettoSprzedazyTowaru

**StawkiVat**
- IdStawkiVat
- Nazwa
- Wartość
- Opis

### **Pytania do analityków biznesowych**
- Czy towar może być różnie oVATowany dla różnych kontrahentów?
- Czy towar może mieć różny VAT dla różnych jednostek miary.