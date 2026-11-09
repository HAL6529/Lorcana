using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_142_JA_03 : CardInfo
{
    public CardInfo_142_JA_03()
    {
        this.cardNo = "142_JA_03";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "É^ÉâÇ®ÇŒÇ†ÇøÇ·ÇÒ";
        this.cardName2 = "êÃòbÇÃéÁÇËéË";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CecileCarreAndAnnaStosik;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
