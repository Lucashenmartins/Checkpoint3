public class MediaMessage : MessageBase
{
    public string File2 { get; set; }
    public string Format { get; set; }
    public MediaMessage(string message) : base(message) { }
}

public class VideoMessage : MediaMessage
{
    public string FileName { get; set; }
    public int Duration { get; set; }

    public VideoMessage(string message, string fileName, int duration) : base(message)
    {
        FileName = fileName;
        Duration = duration;
    }
}
public class PhotoMessage : MediaMessage
{
    
    public PhotoMessage(string message, string File2, string Format) : base(message)
    {
        this.File2 = File2;
        this.Format = Format;
    }
}
public class FileMessage : MediaMessage
{
   public  FileMessage(string message, string File2, string Format) : base(message)
    {
        this.File2 = File2;
        this.Format = Format;
    }
}