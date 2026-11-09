using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_132_JA_03 : CardInfo
{
    public CardInfo_132_JA_03()
    {
        this.cardNo = "132_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "É}ÉEÉCÇÃíﬁÇËêj";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.PeterBrockhammer;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}
