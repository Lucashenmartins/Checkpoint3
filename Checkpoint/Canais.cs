public class WhatsApp
{
    public void EnviarMensagem(string numero, TextMessage message)
    {
        Console.WriteLine($"Enviando mensagem de texto para o número {numero}");
        Console.WriteLine($"Mensagem: {message.Message}");

    }

public void EnviarMensagem(string numero, VideoMessage message)
{
    Console.WriteLine($"Enviando mensagem de video para o número {numero}");
    Console.WriteLine($"Mensagem: {message.Message}");
    Console.WriteLine($"Video: {message.FileName} Duração: {message.Duration} segundos");
}

    public void EnviarMensagem(string numero, PhotoMessage message)
    {
        Console.WriteLine($"Enviando mensagem de foto para o número {numero}");
        Console.WriteLine($"Mensagem: {message.Message}");
        Console.WriteLine($"Foto: {message.File2}Formato: {message.Format}");
    }

    public void EnviarMensagem(string numero, FileMessage message)
    {
        Console.WriteLine($"Enviando mensagem de arquivo para o número {numero}");
        Console.WriteLine($"Mensagem: {message.Message}");
        Console.WriteLine($"Arquivo: {message.File2} Formato: {message.Format}");
    }
}
public class Telegram
{
    public void EnviarMensagem(string numero, TextMessage message)
    {
        Console.WriteLine($"Enviando mensagem de texto para o número {numero}");
        Console.WriteLine($"Mensagem: {message.Message}");

    }
 public void EnviarMensagem(string numero, VideoMessage message)
{
    Console.WriteLine($"Enviando mensagem de video para o número {numero}");
    Console.WriteLine($"Mensagem: {message.Message}");
    Console.WriteLine($"Video: {message.FileName} Duração: {message.Duration} segundos");
}

    public void EnviarMensagem(string numero, PhotoMessage message)
    {
        Console.WriteLine($"Enviando mensagem de foto para o número {numero}");
        Console.WriteLine($"Mensagem: {message.Message}");
        Console.WriteLine($"Foto: {message.File2} Formato: {message.Format}");
    }

    public void EnviarMensagem(string numero, FileMessage message)
    {
        Console.WriteLine($"Enviando mensagem de arquivo para o número {numero}");
        Console.WriteLine($"Mensagem: {message.Message}");
        Console.WriteLine($"Arquivo: {message.File2} Formato: {message.Format}");
    }
}
public class Instagram
{
    public void EnviarMensagem(string numero, TextMessage message)
    {
        Console.WriteLine($"Enviando mensagem de texto para o número {numero}");
        Console.WriteLine($"Mensagem: {message.Message}");

    }
        public void EnviarMensagem(string numero, VideoMessage message)
{
    Console.WriteLine($"Enviando mensagem de video para o número {numero}");
    Console.WriteLine($"Mensagem: {message.Message}");
    Console.WriteLine($"Video: {message.FileName} Duração: {message.Duration} segundos");
}

    public void EnviarMensagem(string numero, PhotoMessage message)
    {
        Console.WriteLine($"Enviando mensagem de foto para o número {numero}");
        Console.WriteLine($"Mensagem: {message.Message}");
        Console.WriteLine($"Foto: {message.File2} Formato: {message.Format}");
    }

    public void EnviarMensagem(string numero, FileMessage message)
    {
        Console.WriteLine($"Enviando mensagem de arquivo para o número {numero}");
        Console.WriteLine($"Mensagem: {message.Message}");
        Console.WriteLine($"Arquivo: {message.File2} Formato: {message.Format}");
    }
}
public class Facebook
{
    public void EnviarMensagem(string numero, TextMessage message)
    {
        Console.WriteLine($"Enviando mensagem de texto para o número {numero}");
        Console.WriteLine($"Mensagem: {message.Message}");
        
    }
    public void EnviarMensagem(string numero, VideoMessage message)
{
    Console.WriteLine($"Enviando mensagem de video para o número {numero}");
    Console.WriteLine($"Mensagem: {message.Message}");
    Console.WriteLine($"Video: {message.FileName} Duração: {message.Duration} segundos");
}

    public void EnviarMensagem(string numero, PhotoMessage message)
    {
        Console.WriteLine($"Enviando mensagem de foto para o número {numero}");
        Console.WriteLine($"Mensagem: {message.Message}");
        Console.WriteLine($"Foto: {message.File2} Formato: {message.Format}");
    }

    public void EnviarMensagem(string numero, FileMessage message)
    {
        Console.WriteLine($"Enviando mensagem de arquivo para o número {numero}");
        Console.WriteLine($"Mensagem: {message.Message}");
        Console.WriteLine($"Arquivo: {message.File2} Formato: {message.Format}");
    }
}