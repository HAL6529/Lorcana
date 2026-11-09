using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_003_JA_04 : CardInfo
{
    public CardInfo_003_JA_04()
    {
        this.cardNo = "003_JA_04";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ÉAÉäÉGÉã";
        this.cardName2 = "êlãõÇÃâÃïP";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MatthewRobertDavies;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Singer7 };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
