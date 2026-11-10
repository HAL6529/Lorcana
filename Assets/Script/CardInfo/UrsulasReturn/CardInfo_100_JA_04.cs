using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_100_JA_04 : CardInfo
{
    public CardInfo_100_JA_04()
    {
        this.cardNo = "100_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ƒrƒWƒ‡ƒ“‚ÌÎ”Â";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.JonasPetrauskas;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}
