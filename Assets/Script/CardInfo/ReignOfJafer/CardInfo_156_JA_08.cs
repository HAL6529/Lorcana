using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_156_JA_08 : CardInfo
{
    public CardInfo_156_JA_08()
    {
        this.cardNo = "156_JA_08";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "オラフ";
        this.cardName2 = "答えはカンタン！";
        this.power = 2;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MattChapman;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
