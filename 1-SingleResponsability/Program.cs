using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper exportHelper = new();
exportHelper.ExportDataToCSV(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");