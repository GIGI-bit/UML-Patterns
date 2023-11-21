

using UML_homework;

var b= new CastleBuilder();
var d = new Director(b);

d.make("Castle");
Castle p = b.getResult();
