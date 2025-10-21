CASE: Add two integers
GIVEN: see example section
WHEN: MathOps.Add(n1,n2) is called
THEN: See expected output in example for verification

Example:

	Input	Expected Output
	N1=100	300
	N2=200
	N1=100	50
	N2=-50
	N1=-100	-300
	N2=-200

Example:

	Input	Expected Output
	N1=100.5	Enter an integer
	N2=100
	N1=100	Enter an integer
	N2=8.5
	
CASE: Multiply two integers
GIVEN: see example section
WHEN: MathOps.Multiply(n1,n2) is called
THEN: See expected output in example for verification

Example:

	Input	Expected Output
	N1=3	15
	N2=5
	N1=70	210
	N2=3
	N1=-5	-45
	N1=9
	N1=6	42
	N2=-7
	N1=-8	72
	N2=-9

CASE: Substract two integers
GIVEN: see example section
WHEN: MathOps.Sub(n1,n2) is called
THEN: See expected output in example for verification

	Input	Expected Output
	N1=3	1
	N2=2
	N1=5	10
	N2=-5
	N1=5	-3
	N2=8
	N1=-5	-10
	N2=5

CASE: Devide two integers
GIVEN: see example section
WHEN: MathOps.Div(n1,n2) is called
THEN: See expected output in example for verification

	Input	Expected Output
	N1=15	5
	N2=3
	N1=15	Error
	N2=0
