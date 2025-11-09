// See https://aka.ms/new-console-template for more information
Console.WriteLine("Para qual canal você quer enviar mensagem?");
Console.WriteLine("1. WhatsApp");
Console.WriteLine("2. Telegram");
Console.WriteLine("3. Instagram");
Console.WriteLine("4. Facebook");

int canal = 0;
string resposta = Console.ReadLine();
if (!int.TryParse(resposta, out canal))
{
    Console.WriteLine("Opção inválida");
    return;
}

TextMessage messageBase = new TextMessage("Olá");
VideoMessage video = new VideoMessage("Olá");
PhotoMessage photo = new PhotoMessage("Olá");
FileMessage file = new FileMessage("Olá");
if(canal == 1)
{
    ﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Qual tipo de mensagem você quer enviar via Whatapp? ");
Console.WriteLine("1. Texto");
Console.WriteLine("2. Vídeo");
Console.WriteLine("3. Foto");
Console.WriteLine("4. Arquivo");

int MSGtype = 0;
string respostamsg = Console.ReadLine();
    if (!int.TryParse(respostamsg, out MSGtype))
    {
        Console.WriteLine("Opção inválida");
        return;
    }
    if (MSGtype == 1)
    {
        var whats = new WhatsApp();
        whats.EnviarMensagem("12345678", messageBase);
    }
    if (MSGtype == 2)
    {
        var whats = new WhatsApp();
        whats.EnviarMensagem("12345678", video);
    }
    if (MSGtype == 3)
    {
        var whats = new WhatsApp();
        whats.EnviarMensagem("12345678", photo);
    }
    if (MSGtype == 4)
    {
        var whats = new WhatsApp();
        whats.EnviarMensagem("12345678", file);
    }
}
if (canal == 2)
{
  Console.WriteLine("Qual tipo de mensagem você quer enviar via Telegram? ");
    Console.WriteLine("1. Texto");
    Console.WriteLine("2. Vídeo");
    Console.WriteLine("3. Foto");
    Console.WriteLine("4. Arquivo");
    int MSGtype = 0;
    string respostamsg = Console.ReadLine();
    if (!int.TryParse(respostamsg, out MSGtype))
    {
        Console.WriteLine("Opção inválida");
        return;
    }
    if (MSGtype == 1)
    {
        var telegram = new Telegram();
        telegram.EnviarMensagem("12345678", messageBase);
    }
    if (MSGtype == 2)
    {
        var telegram = new Telegram();
        telegram.EnviarMensagem("12345678", video);
    }
    if (MSGtype == 3)
    {
        var telegram = new Telegram();
        telegram.EnviarMensagem("12345678", photo);
    }
    if (MSGtype == 4)
    {
        var telegram = new Telegram();
        telegram.EnviarMensagem("12345678", file);
    }
}
if (canal == 3)
{
   Console.WriteLine("Qual tipo de mensagem você quer enviar via Instagram? ");
    Console.WriteLine("1. Texto");
    Console.WriteLine("2. Vídeo");
    Console.WriteLine("3. Foto");
    Console.WriteLine("4. Arquivo");
    int MSGtype = 0;
    string respostamsg = Console.ReadLine();
    if (!int.TryParse(respostamsg, out MSGtype))
    {
        Console.WriteLine("Opção inválida");
        return;
    }
    if (MSGtype == 1)
    {
        var instagram = new Instagram();
        instagram.EnviarMensagem("12345678", messageBase);
    }
    if (MSGtype == 2)
    {
        var instagram = new Instagram();
        instagram.EnviarMensagem("12345678", video);
    }
    if (MSGtype == 3)
    {
        var instagram = new Instagram();
        instagram.EnviarMensagem("12345678", photo);
    }
    if (MSGtype == 4)
    {
        var instagram = new Instagram();
        instagram.EnviarMensagem("12345678", file);
    }
}
if (canal == 4)
{
    Console.WriteLine("Qual tipo de mensagem você quer enviar via Facebook? ");
    Console.WriteLine("1. Texto");
    Console.WriteLine("2. Vídeo");
    Console.WriteLine("3. Foto");
    Console.WriteLine("4. Arquivo");
    int MSGtype = 0;
    string respostamsg = Console.ReadLine();
    if (!int.TryParse(respostamsg, out MSGtype))
    {
        Console.WriteLine("Opção inválida");
        return;
    }
    if (MSGtype == 1)
    {
        var facebook = new Facebook();
        facebook.EnviarMensagem("12345678", messageBase);
    }
    if (MSGtype == 2)
    {
        var facebook = new Facebook();
        facebook.EnviarMensagem("12345678", video);
    }
    if (MSGtype == 3)
    {
        var facebook = new Facebook();
        facebook.EnviarMensagem("12345678", photo);
    }
    if (MSGtype == 4)
    {
        var facebook = new Facebook();
        facebook.EnviarMensagem("12345678", file);
    }
    
}