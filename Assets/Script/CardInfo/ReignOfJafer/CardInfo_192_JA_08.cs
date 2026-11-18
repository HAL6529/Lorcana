using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_192_JA_08 : CardInfo
{
    public CardInfo_192_JA_08()
    {
        this.cardNo = "192_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ジッパー";
        this.cardName2 = "空飛ぶレンジャー";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.IanMacDonald;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
