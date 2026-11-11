using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_068_JA_05 : CardInfo
{
    public CardInfo_068_JA_05()
    {
        this.cardNo = "068_JA_05";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ê}èëé∫";
        this.cardName2 = "ÉxÉãÇ÷ÇÃë°ÇËï®";
        this.power = 1;
        this.toughness = 8;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RobertoGatto;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Uncommon;
    }
}
