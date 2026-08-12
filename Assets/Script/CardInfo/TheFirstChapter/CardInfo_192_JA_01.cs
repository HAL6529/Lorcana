using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_192_JA_01 : CardInfo
{
    public CardInfo_192_JA_01()
    {
        this.cardNo = "192_JA_01";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "テ・カァ";
        this.cardName2 = "心なきもの";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = "Andrew Trabbold";
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Deity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
