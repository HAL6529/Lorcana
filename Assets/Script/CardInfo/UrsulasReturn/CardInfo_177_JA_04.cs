using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_177_JA_04 : CardInfo
{
    public CardInfo_177_JA_04()
    {
        this.cardNo = "177_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "チ・フー";
        this.cardName2 = "皇帝顧問";
        this.power = 0;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GakuKumatori;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
