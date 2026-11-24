using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_094_JA_12 : CardInfo
{
    public CardInfo_094_JA_12()
    {
        this.cardNo = "094_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "兵士";
        this.cardName2 = "女王の命令のままに";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LorenzaPigliamosche;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
