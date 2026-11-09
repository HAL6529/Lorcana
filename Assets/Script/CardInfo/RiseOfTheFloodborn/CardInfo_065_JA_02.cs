using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_065_JA_02 : CardInfo
{
    public CardInfo_065_JA_02()
    {
        this.cardNo = "065_JA_02";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "”j‚ê‚È‚¢Œ_–ñ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.KasiaBrzezinska;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}
