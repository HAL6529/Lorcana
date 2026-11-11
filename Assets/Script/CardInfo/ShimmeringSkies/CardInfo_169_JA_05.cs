using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_169_JA_05 : CardInfo
{
    public CardInfo_169_JA_05()
    {
        this.cardNo = "169_JA_05";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ëÂÉCÉãÉ~Éi";
        this.cardName2 = "Ç´ÇÁÇﬂÇ≠ïëì•èÍ";
        this.power = 2;
        this.toughness = 9;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.CarlosRuiz;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Lorcana;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}
