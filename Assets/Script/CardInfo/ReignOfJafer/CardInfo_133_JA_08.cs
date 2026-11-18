using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_133_JA_08 : CardInfo
{
    public CardInfo_133_JA_08()
    {
        this.cardNo = "133_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "フィガロ";
        this.cardName2 = "タキシード・キャット";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SauloNate;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Pinocchio;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
