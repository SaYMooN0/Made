﻿namespace MadeLib.Src.TabContentClasses
{
	public abstract class ModifyRecipes
    {
		public const string Main =
           "<link href=\"_content/MadeLib/css/tab_content/components.css\" rel=\"stylesheet\" />" +
           "<div class=\"action-buttons-container-5\">"+

		   "<div id=\"newRecipeDiv\" class=\"action-button\">" +
                "<label class=\"action-button-main-label\">Add vanilla recipe</label>"+
                "<label class=\"action-button-hint-label\">Create recipes for crafting stations from vanilla minecraft </label>" +
            "</div>" +
           "<div id=\"deleteRecipeDiv\" class=\"action-button\">" +
                "<label class=\"action-button-main-label\">Delete recipe</label> " +
                "<label class=\"action-button-hint-label\">Delete creation recipes for items and tags</label>" +
            "</div>" +
           "<div id=\"changeRecipeDiv\" class=\"action-button\">" +
                "<label class=\"action-button-main-label\">Change recipe</label> " +
                "<label class=\"action-button-hint-label\">Edit the recipes you have already created</label>" +
            "</div>" +
            "<div id=\"moddedRecipeDiv\" class=\"action-button\">" +
                "<label class=\"action-button-main-label\">Add modded recipe</label> " +
                "<label class=\"action-button-hint-label\">Create recipes for mods that are supported by Made</label>" +
            "</div>" +
           "<div id=\"groupRecipeDiv\" class=\"action-button\">" +
                "<label class=\"action-button-main-label\">Add recipe group</label> " +
                "<label class=\"action-button-hint-label\">Create recipes for machines from mods at a time</label>" +
            "</div>" +

           "</div>";


	}
}
