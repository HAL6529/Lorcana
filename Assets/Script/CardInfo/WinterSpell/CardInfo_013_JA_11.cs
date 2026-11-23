using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_013_JA_11 : CardInfo
{
    public CardInfo_013_JA_11()
    {
        this.cardNo = "013_JA_11";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "柳の木のおばあさん";
        this.cardName2 = "古き善き相談相手";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MarianaMoreno;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Pocahontas;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
