using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_094_JA_08 : CardInfo
{
    public CardInfo_094_JA_08()
    {
        this.cardNo = "094_JA_08";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "デール";
        this.cardName2 = "危険に陥るリス";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.WouterBruneel;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
