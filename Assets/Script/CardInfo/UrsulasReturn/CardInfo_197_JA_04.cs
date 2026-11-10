using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_197_JA_04 : CardInfo
{
    public CardInfo_197_JA_04()
    {
        this.cardNo = "197_JA_04";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "One Last Hope";
        this.cardName2 = "ç≈å„ÇÃñ≤";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Rare;
    }
}
