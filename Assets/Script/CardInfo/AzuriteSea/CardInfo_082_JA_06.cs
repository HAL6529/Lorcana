using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_082_JA_06 : CardInfo
{
    public CardInfo_082_JA_06()
    {
        this.cardNo = "082_JA_06";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "マートル・エドモンズ";
        this.cardName2 = "リロのライバル";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GonzaloKenny;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
