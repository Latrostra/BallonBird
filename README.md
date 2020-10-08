# BallonBird
Gra polega na omijaniu przeszkód jako gracz. Za każdą ominiętą przeszkodę gracz zostaje nagrodzony wzrostem punktacji. Gracz przegrywa grę jeżeli skończą mu sie punkty życia.

Gracz:

Wszystkie potrzebne zależności do funkcjonowania obiektu gracz są przekazywane w komponencie PlayerBallon. Implementacja interfejsu IInput przekazuję stan wejścia do klasy PlayerBallon, która na tej podstawie podejmuję decyzję o zmiane wektora szybkości. Komponent health przekazuję niezbędne metody do zarządzania ilością zdrowia.

•	Gracz ma możliwość ruchu po osi Y (góra i dół)

![Image of Movement](https://github.com/Latrostra/BallonBird/blob/master/picture.PNG)

•	Ruch w górę jest uzależniony od przekazanego wejścia przez gracza powiększa to wartość wektora szybkości w osi Y.
Ruch w dół jest automatyczny i zależy od wartości grawitacji. Wartość grawitacji pomniejsza wartość wektora przyspieszenia w osi Y.

•	Szybkość wzrostu wektora przyspieszenia jest z góry nadana przed startem programu.

•	Wartość punktów życia jest z góry nadana przed startem programu. Gracz traci punkty życia, jeżeli dojdzie do kolizji między nim, a przeciwnikiem.

•	Przy stracie wszystkich punktów życia, gracz przegrywa grę, skutkując przejście do menu restartu.

Input:

W każdej klatce trwania gry, komponent zwraca prawdę jeżeli w danej klatce lewy przycisk myszy jest wciśnięty. W przeciwnym wypadku zwraca fałsz.

•	Lewy przycisk myszy – odpowiada za ruch w góre gracza w osi Y.

• Implementacja interfejsu metody bool.

Przeciwnicy:

Działanie tego systemu polega na przekazywaniu dezaktywnych obiektów przeciwników przez komponent ObjectPooler do ObstacleSpawner. ObstacleSpawner komponent odpowiada na przygotowaniu araz aktywacji obiektu przeciwnika.

•	Przeciwnicy są inicjalizowani przed startem rozgrywki (object pooling).

•	Przeciwnicy są aktywowani wraz z upływem czasu  i dezaktywowani, jeźeli dojdzie do kolizji między obiektem przeciwnika, a obiektem dezaktywującym.

•	Przeciwnicy pojawiają się w równych odstępach czasu, odstępy czasowe są z góry nadane przed startem gry.

•	Po aktywacji obiektu przeciwnika, wektor pozycji przeciwnika jest resetowany do wartości podstawowych. 

•	Przeciwnicy nie mają możliwości poruszania się w kierunku –X.

•	W grze występują 2 rodzaje przeciwników. 

• Drzewo porusza się wyłącznie po osi X w kierunki –X o stałą wartość.

•	Ruch ptaka polega na dodanie wektora mocy (AddForce) i uczynienie go podatnym na grawitacje. Tworzy to efekt paraboli lotu.

![Image of enemy Movement](https://github.com/Latrostra/BallonBird/blob/master/picture1.PNG)

Ui:

Ilość punktów jest przechowywania w scriptable object (pseudo baza danych) i resetowana przy każdym restarcie rozgrywki.

•	Menu restartu pozwala na zaczęcie gry od początku lub zakończenie działania gry.

•	W menu restartu podana jest wartość uzyskanego wyniku.

•	Punkty zwiększają się o stała wartość podaną przed startem programu.

•	Punkty przyznawane są za każdą ominiętą przeszkode.

•	Ui zmienia się wraz z wystąpieniem odpowiedniego eventu.


Środowisko:

•	Tło przesuwa swój wektor przesunięcia, skutkując niekończącą pętlę tekstury. Podział tła na wiele elementów pozwala na dostosowywanie szybkości zmiany wektora przesunięcia. Skutkuje to uzyskaniem efektu paralaksy.

•	Tło trzęsie się jeżeli dojdzie do kolizji gracza z obiektem aktywującym efekt.
