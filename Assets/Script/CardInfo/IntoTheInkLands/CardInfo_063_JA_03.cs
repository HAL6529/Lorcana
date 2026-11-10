using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_063_JA_03 : CardInfo
{
    public CardInfo_063_JA_03()
    {
        this.cardNo = "063_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "‚â‚Á‚Æ‰^‚ªŒü‚¢‚Ä—ˆ‚½‚í";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.Koni;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Rare;
    }
}
