Console.WriteLine("Tipo de incidente: \n1. Malware \n2. Phishing \n3. Acceso no autorizado \n4. Fuga de informacion");
int incidente = int.Parse(Console.ReadLine());
Console.WriteLine("Activo afectado: \n1. PC \n2. Servidor \n3. Base de datos \n4. Red");
int activo = int.Parse(Console.ReadLine());
Console.WriteLine("Datos comprometidos: \n1. Ninguno \n2. Internos \n3. Personales \n4. Financieros");
int datos = int.Parse(Console.ReadLine());
Console.WriteLine("Persistencia detectada S/N:");
string persistencia = Console.ReadLine();
Console.WriteLine("Numero de usuarios afectados:");
int usuarios = int.Parse(Console.ReadLine());
string tipoIncidente = "";
string tipoActivo = "";
string severidad = "";
string respuesta = "";
if (incidente >= 1 && incidente <= 4 &&
    activo >= 1 && activo <= 4 &&
    datos >= 1 && datos <= 4 &&
    (persistencia == "s" || persistencia == "n") &&
    usuarios >= 0)
{
    switch (incidente)
    {
        case 1:
            tipoIncidente = "Malware";
            break;
        case 2:
            tipoIncidente = "Phishing";
            break;
        case 3:
            tipoIncidente = "Acceso no autorizado";
            break;
        case 4:
            tipoIncidente = "Fuga de informacion";
            break;
    }
    switch (activo)
    {
        case 1:
            tipoActivo = "PC";
            break;
        case 2:
            tipoActivo = "Servidor";
            break;
        case 3:
            tipoActivo = "Base de datos";
            break;
        case 4:
            tipoActivo = "Red";
            break;
    }
    if (incidente == 4 && datos == 4)
    {
        severidad = "Critica";
        respuesta = "iniciar protocolo legal y notificar a las autoridades";
    }
    else if (incidente == 1 && activo == 2 && persistencia == "s")
    {
        severidad = "Critica";
        respuesta = "Cuarentena e investigación de datos";
    }
    else if (usuarios <= 5 && datos == 1)
    {
        severidad = "Baja";
        respuesta = "Seguimiento y registro";
    }
    else if (datos == 3 || datos == 4)
    {
        severidad = "Alta";
        respuesta = "Renovar acceso y avisar.";
    }
    else
    {
        severidad = "Media";
        respuesta = "Diagnóstico y mejora de seguridad";
    }
    Console.WriteLine($"Incidente: {tipoIncidente}");
    Console.WriteLine($"Incidente: {tipoActivo}");
    Console.WriteLine($"Incidente: {severidad}");
    Console.WriteLine($"Incidente: {respuesta}");
}
else
{
    Console.WriteLine("Datos no validos.");
}