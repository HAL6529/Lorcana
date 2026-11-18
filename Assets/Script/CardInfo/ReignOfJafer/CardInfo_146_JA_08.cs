using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_146_JA_08 : CardInfo
{
    public CardInfo_146_JA_08()
    {
        this.cardNo = "146_JA_08";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "プリンス・ジョン";
        this.cardName2 = "腰抜けネコ";
        this.power = 5;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.DennyMinonne;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
