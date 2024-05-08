using System;
using System.ComponentModel;
using System.Security.Cryptography;
using Microsoft.Win32;

public class StorageRegistry
{
    [Description("Сохранение данных в реестре")]
    public static void SaveToRegistry(string keyName, byte[] data)
    {
        RegistryKey key = Registry.CurrentUser.CreateSubKey(keyName);
        key.SetValue("Data", data);
    }

    [Description("Получение данных из реестра")]
    public static byte[] GetFromRegistry(string keyName)
    {
        RegistryKey key = Registry.CurrentUser.OpenSubKey(keyName);
        return (byte[])key.GetValue("Data");
    }
}