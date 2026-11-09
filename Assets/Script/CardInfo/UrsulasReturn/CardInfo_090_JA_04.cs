using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_090_JA_04 : CardInfo
{
    public CardInfo_090_JA_04()
    {
        this.cardNo = "090_JA_04";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ミューズ";
        this.cardName2 = "アートとヒーローの専門家";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.BrittneyHackett;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
