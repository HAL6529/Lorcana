using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_031_JA_08 : CardInfo
{
    public CardInfo_031_JA_08()
    {
        this.cardNo = "031_JA_08";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "アントニオのジャガー";
        this.cardName2 = "いつもいっしょのおとも";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.DennyMinonne;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
