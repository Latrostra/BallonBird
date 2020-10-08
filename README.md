# BallonBird
Gra polega na omijaniu przeszkód jako gracz. Za każdą ominiętą przeszkodę gracz zostaje nagrodzony wzrostem punktacji. Gracz przegrywa grę jeżeli skończą mu sie punkty życia.

Gracz:

•	Gracz ma możliwość ruchu po osi Y (góra i dół)  
•	Ruch w górę jest uzależniony od przekazanego wejścia przez gracza powiększa to wartość wektora szybkości w osi Y.
Ruch w dół jest automatyczny i zależy od wartości grawitacji. Wartość grawitacji pomniejsza wartość wektora przyspieszenia w osi Y.
•	Szybkość wzrostu wektora przyspieszenia jest z góry nadana przed startem programu.
•	Wartość punktów życia jest z góry nadana przed startem programu. Gracz traci punkty życia, jeżeli dojdzie do kolizji między nim, a przeciwnikiem.
•	Przy stracie wszystkich punktów życia, gracz przegrywa grę, skutkując przejście do menu restartu.
• Komponent PlayerBallon odpowiada za wszyskie zależnośći do odpowiedniego działania obiektu gracza. (Input, Health)

Input:

•	Lewy przycisk myszy – Ruch w górę. Zwiększenie wektora przyspieszenia.
• Implementacja interfejsu metody bool.

Przeciwnicy:

•	Przeciwnicy są inicjalizowani przed startem rozgrywki (object pooling).
•	Przeciwnicy są aktywowani wraz z upływem czasu  i dezaktywowani, jeźeli dojdzie do kolizji między obiektem przeciwnika, a obiektem dezaktywującym.
•	Po aktywacji obiektu przeciwnika, wektor pozycji przeciwnika jest resetowany do wartości podstawowych. 
•	Przeciwnicy nie mają możliwości poruszania się w kierunku –X.
•	Przeciwnicy pojawiają się w równych odstępach czasu, odstępy czasowe są z góry nadane przed startem gry.
•	W grze występują 2 rodzaje przeciwników. Drzewo porusza się wyłącznie po osi X w kierunki –X o stałą wartość. Ptak porusza się po paraboli.
•	Ruch ptaka polega na dodanie wektora mocy (AddForce) i uczynienie go podatnym na grawitacje.
• Działanie tego systemu polega na przekazywaniu dezaktywnych przeciwników przez komponent ObjectPooler do ObstacleSpawner. ObstacleSpawner komponent odpowiada na przygotowaniu araz aktywacji obiektu przeciwnika.

Ui:

•	Menu restartu pozwala na zaczęcie gry od początku lub zakończenie działania gry.
•	Punkty zwiększają się o stała wartość podaną przed startem programu.
•	Punkty przyznawane są za każdą ominiętą przeszkode.
•	Ui zmienia się wraz z wystąpieniem odpowiedniego eventu.
•	Ilość punktów jest przechowywania w scriptable object (pseudo baza danych) i resetowana przy każdym restarcie rozgrywki.

Środowisko:

•	Tło przesuwa swój wektor przesunięcia, skutkując niekończącą pętlę tekstury. Podział tła na wiele elementów pozwala na dostosowywanie szybkości zmiany wektora przesunięcia. Skutkuje to uzyskaniem efektu paralaksy.

•	Tło trzęsie się jeżeli dojdzie do kolizji gracza z obiektem aktywującym efekt.
