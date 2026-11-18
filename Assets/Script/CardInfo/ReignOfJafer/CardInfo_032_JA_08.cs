using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_032_JA_08 : CardInfo
{
    public CardInfo_032_JA_08()
    {
        this.cardNo = "032_JA_08";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "カルホーン";
        this.cardName2 = "厳格な指揮官";
        this.power = 4;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.EduFranciscoAndAmandaDuarte;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
