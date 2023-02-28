using System;

public interface ITableRepository
{
    string GetAll();
}

public class TableInMemoryRepository : ITableRepository
{
    public string GetAll()
    {
        return "인-메모리 데이터베이스 사용";
    }
}

public class TableSqlRepository : ITableRepository
{
    public string GetAll() => "SQL Server 데이터베이스 사용";
}
public class TableXmlRepository : ITableRepository
{
    public string GetAll() => "XML 데이터베이스 사용";
}

class RepositoryPatternDemo
{
    static void Main()
    {
        //SQL, InMemory, XML 등 넘어오는 값에 따른 인스턴스 생성(저장소 결정)
        string repo = "SQL"; // SQL, InMemory, XML 중 하나로 변경

        ITableRepository repository;
        if (repo == "InMemory")
        {
            repository = new TableInMemoryRepository();
        }
        else if (repo == "XML")
        {
            repository = new TableXmlRepository();
        }
        else
        {
            repository = new TableSqlRepository();
        }

        Console.WriteLine(repository.GetAll());
    }
}