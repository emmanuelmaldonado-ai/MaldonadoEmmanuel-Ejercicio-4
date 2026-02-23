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

string severidad = "baja";
string respuesta = "revisión constante";

switch (tipoincidente)
{
    case 1:
        if (persistencia == "s")
        {
            if (activoafectado == 2 || activoafectado == 3)
            {
                severidad = "Critica";
                respuesta = "Aislar todo inmediatamente";
            }
            else
            {
                severidad = "alta ";
                respuesta = "Formatear";
            }
        }
        break;
    case 2:
        if (usuariosafect > 50)
        {
            severidad = "media";
            respuesta = "Reinicio masivo";
        }
        break;
    case 4:
        if (datoscomprom == 4)
        {
            severidad = "Critica";
            respuesta = "emergencia legal y finaciera";
        }
        else if (datoscomprom == 3)
        {
            severidad = "alta";
            respuesta = "privacidad afectada";
        }
        break;
}
switch (activoafectado)
{
    case 3: 
        if (severidad == "baja")
        {
            severidad = "media";
            respuesta = "revisar integridad de datos";
        }
        break;
    case 4:
        if (usuariosafect > 500)
        {
            severidad = "critica";
        }
        else if (usuariosafect > 100)
        {
            if (severidad == "baja")
            {
                severidad = "media";
            }
        }break;
}

Console.WriteLine("Resultados evaluados");
Console.WriteLine($"Severidad final: {severidad}");
Console.WriteLine($"respuesta sugerida: {respuesta}");
