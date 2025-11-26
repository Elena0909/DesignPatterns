// See https://aka.ms/new-console-template for more information
using AdapterPattern;

Console.WriteLine("----- Adapter Pattern -----\n");

ILogSaver logSaver = new CloudLogSaverAdapter();
//ILogSaver logSaver = new DatabaseLogSaver();

Log successLog = new Log("Success all commands!");
Log errorLog = new Log("Something was wrong", "500 Error Server");

logSaver.SaveLog(successLog);
logSaver.SaveError(errorLog);