using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_095_JA_04 : CardInfo
{
    public CardInfo_095_JA_04()
    {
        this.cardNo = "095_JA_04";
        this.inkCost = 8;
        this.availableInk = false;
        this.cardName1 = "Under the Sea";
        this.cardName2 = "アンダー・ザ・シー";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.DylanBonner;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.SingTogether8 };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Rare;
    }
}
