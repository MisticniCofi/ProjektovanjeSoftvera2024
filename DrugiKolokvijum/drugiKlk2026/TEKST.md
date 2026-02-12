###Drugi kolokvijum 2026

Klijent server aplikacija

Server - konzola
Klijent - forma
3 registrovana korisnika u operativnoj memoriji
Server na pocetku rada unosi maksimalan broj istovremeno povezanih klijenata

Klijent salje poruke:
LOGIN korisnicko_ime - ERROR ako je klijent vec povezan ili ako nema vise mesta na serveru
SEND korisnicko_ime; poruka - server treba da odgovori da je primio poruku
LOGOUT korisnicko_ime

Ako se klijent 10 sekundi nakon otvaranja forme ne uloguje, forma se zatvara

Server na 5 sekundi ispisuje imena registrovanih korsisnika i status (ulogovani/neulogovani)