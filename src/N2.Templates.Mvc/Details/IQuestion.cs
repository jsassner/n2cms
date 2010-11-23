﻿using N2.Web;

namespace N2.Templates.Mvc.Details
{
	public interface IQuestion
	{
		TagBuilder CreateHtmlElement();
		string QuestionText { get; }
		string ElementID { get; }
		string GetAnswerText(string value);
	}
}