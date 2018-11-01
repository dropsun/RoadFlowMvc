using System.Linq;
using System.Web;

public class UECrawlerHandler : UEHandler
{
	private string[] Sources;

	private UECrawler[] Crawlers;

	public UECrawlerHandler(HttpContext context)
		: base(context)
	{
	}

	public override void Process()
	{
		Sources = base.Request.Form.GetValues("source[]");
		if (Sources == null || Sources.Length == 0)
		{
			WriteJson(new
			{
				state = "参数错误：没有指定抓取源"
			});
		}
		else
		{
			Crawlers = (from x in Sources
			select new UECrawler(x, base.Server).Fetch()).ToArray();
			WriteJson(new
			{
				state = "SUCCESS",
				list = from x in Crawlers
				select new
				{
					state = x.State,
					source = x.SourceUrl,
					url = x.ServerUrl
				}
			});
		}
	}
}
