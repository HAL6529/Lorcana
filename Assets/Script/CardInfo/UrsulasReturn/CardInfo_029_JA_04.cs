using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_029_JA_04 : CardInfo
{
    public CardInfo_029_JA_04()
    {
        this.cardNo = "029_JA_04";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "Lost in the Woods";
        this.cardName2 = "—ö‚Ì–À‚¢Žq";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.EllieHorie;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Uncommon;
    }
}
