using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_109_JA_04 : CardInfo
{
    public CardInfo_109_JA_04()
    {
        this.cardNo = "109_JA_04";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ƒwƒ‰ƒNƒŒƒX";
        this.cardName2 = "‘å’_•s“G‚Èƒfƒ~ƒSƒbƒh";
        this.power = 7;
        this.toughness = 3;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.DiogoSaito;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Rush, EnumController.KeywordAvility.Reckless };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
