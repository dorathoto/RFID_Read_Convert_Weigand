namespace RFID_Read_Convert_Weigand
{
    /// <summary>
    /// Não existe algo universal para clipboard já que linux, windows e MacOs tem suas particularidades.
    /// Sem usar biblioteca de terceiros uma forma é utilizar o powershel já que o mesmo tem suporte a todas plataformas.
    /// Powershell já vem instalado em qualquer windows XP ou superior no linux e mac precisa instalar.
    /// </summary>
    internal class Clipboard
    {
        public static void SetByPowershell(string text)
        {
            var escapedArgs = text.Replace("\"", "\\\"");
            var process = new System.Diagnostics.Process()
            {
                StartInfo = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = $"-command \"Set-Clipboard -Value \\\"{escapedArgs}\\\"\"",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };
            process.Start();
        }


    }
}
