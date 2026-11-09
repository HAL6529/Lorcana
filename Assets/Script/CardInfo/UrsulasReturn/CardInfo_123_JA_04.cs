using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_123_JA_04 : CardInfo
{
    public CardInfo_123_JA_04()
    {
        this.cardNo = "123_JA_04";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ÉVÉXÅ[";
        this.cardName2 = "ëÂí_ïsìGÇ»óàñKé“";
        this.power = 1;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.OttoParedes;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Deity, EnumController.Class.Dragon };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
