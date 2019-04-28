RandomQueue
===========

Die Klasse RandomQueue generiert nicht negative Zufallszahlen vom Typ System.Int32. Die öffentliche Methode Next() liefert eine Zufallszahl, deren Wert im Bereich von 0 bis zur exklusiven, oberen Grenze MaxValue liegt. Die Klasse stellt durch eine Queue sicher, dass nur Zahlen geliefert werden, die sich nicht eine bestimmte Anzahl Aufrufe der Methode Next() wiederholen. Diese Anzahl wird im Konstruktor-Parameter lastIgnoreCount übergeben.

