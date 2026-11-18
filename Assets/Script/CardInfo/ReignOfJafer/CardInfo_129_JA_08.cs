using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_129_JA_08 : CardInfo
{
    public CardInfo_129_JA_08()
    {
        this.cardNo = "129_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ガストン";
        this.cardName2 = "傲慢な自慢屋";
        this.power = 4;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.Samoldstoree;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
