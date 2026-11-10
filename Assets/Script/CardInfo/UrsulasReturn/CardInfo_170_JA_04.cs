using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_170_JA_04 : CardInfo
{
    public CardInfo_170_JA_04()
    {
        this.cardNo = "170_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "“~‚Ì–ì‰c’n";
        this.cardName2 = "Ž¡—Ã‚Ì–‹‰®";
        this.power = 1;
        this.toughness = 8;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ElodieMondoloni;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Common;
    }
}
