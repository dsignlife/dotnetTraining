using System;
using System.IO;

namespace PragueParking2
{
    /// <summary>
    /// Functions for performing common binary Serialization operations.
    /// <para>All properties and variables will be serialized.</para><para>Object type (and all child types) must be decorated with the [Serializable] attribute.</para><para>To prevent a variable from being serialized, decorate it with the [NonSerialized] attribute; cannot be applied to properties.</para>
    /// </summary>
    [Serializable]
    public class WriteToBin
    {
        /// <summary>
        /// Writes to binary file.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filePath">The file path.</param>
        /// <param name="objectToWrite">The object to write.</param>
        /// <param name="append">if set to <c>true</c> [append].</param>
        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
        {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }
    }
}