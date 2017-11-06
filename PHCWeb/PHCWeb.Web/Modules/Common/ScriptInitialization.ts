/// <reference path="../Common/Helpers/LanguageList.ts" />

namespace PHCWeb.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('PHCWeb');
    Serenity.EntityDialog.defaultLanguageList = LanguageList.getValue;
}