using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_222_JA_09 : CardInfo
{
    public CardInfo_222_JA_09()
    {
        this.cardNo = "222_JA_09";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "One Last Hope";
        this.cardName2 = "最後の夢";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol1;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Epic;
    }
}
