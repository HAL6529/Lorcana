using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_117_JA_03 : CardInfo
{
    public CardInfo_117_JA_03()
    {
        this.cardNo = "117_JA_03";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ÉÇÉAÉi";
        this.cardName2 = "Ç≠Ç∂ÇØÇ»Ç¢ó∑êl";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MilaUseche;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
