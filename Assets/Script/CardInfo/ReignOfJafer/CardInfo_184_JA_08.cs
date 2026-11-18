using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_184_JA_08 : CardInfo
{
    public CardInfo_184_JA_08()
    {
        this.cardNo = "184_JA_08";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "アクメッド王子";
        this.cardName2 = "ライバル求婚者";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JakeMurphy;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
