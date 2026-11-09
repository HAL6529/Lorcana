using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_064_JA_03 : CardInfo
{
    public CardInfo_064_JA_03()
    {
        this.cardNo = "064_JA_03";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "–‚–@‚Ìƒ‰ƒ“ƒv";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.EverGalvezAndAnnaStosik;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}
