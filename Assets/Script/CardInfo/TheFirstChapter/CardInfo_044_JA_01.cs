using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_044_JA_01 : CardInfo
{
    public CardInfo_044_JA_01()
    {
        this.cardNo = "044_JA_01";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ジャファー";
        this.cardName2 = "秘密の管理者";
        this.power = 0;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = "Marcel Berg";
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
