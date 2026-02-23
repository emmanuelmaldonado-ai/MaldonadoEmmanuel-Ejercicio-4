// Clasificación de incidente de seguridad informática

Console.WriteLine("Clasificación de incidente");
Console.WriteLine("Tipo de incidente: 1 Malware, 2 Phishing, 3 Acceso no autorizado, 4 Fuga de información");
int tipoincidente = int.Parse(Console.ReadLine());
Console.WriteLine("Activo afectado: 1 PC, 2 Servidor, 3 Base de datos, 4 Red");
int activoafectado = int.Parse(Console.ReadLine());
Console.WriteLine("Datos comprometidos: 1 Ninguno, 2 Internos, 3 Personales, 4 Financieros");
int datoscomprom = int.Parse(Console.ReadLine());
Console.WriteLine("Persistencia detectada (s/n)");
string persistencia = Console.ReadLine();
Console.WriteLine("Número de usuarios afectados");
int usuariosafect = int.Parse(Console.ReadLine());

