namespace LearnignCenter.infraestructura;

public class TutorialOracleInfraestructure:iTutorialInfraestructure
{
  public  List<string>GetAll()
  {
    List<string> list = new List<string>();
    list.Add("Tutorial Oracle 1");
    list.Add("Tutorial Oracle 2");
    list.Add("Tutorial Oracle 3");
    list.Add("Tutorial Oracle 4");


    return list;
  }
}


