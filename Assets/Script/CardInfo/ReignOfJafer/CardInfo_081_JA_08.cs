using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_081_JA_08 : CardInfo
{
    public CardInfo_081_JA_08()
    {
        this.cardNo = "081_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "INTO THE UNKNOWN";
        this.cardName2 = "イントゥ・ジ・アンノウン";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.MariaDresden;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.SuperRare;
    }
}
